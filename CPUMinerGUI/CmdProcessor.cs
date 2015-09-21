using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace OpenSimWin {
    public class CmdProcessor {
        /// 
        /// Execute takes a command string to pass as the arguments to cmd.exe.       
        /// 
        /// The command to execute. 
        /// Examples: 
        ///   "dir" 
        ///   "type ..\..\comdprocessor.cs"
        /// 
        public void Execute(string command) {
            _process = InitializeProcess(command);
            _executing = true;
            _process.Start();
            AttachStreams();
            PrepareAsyncState();
            // read the streans asynchronously so 
            // control will return to the caller
            _standardOutput.BaseStream.BeginRead(
               _outputBuffer, 0,
               _outputBuffer.Length,
               _outputReady,
               _outputState
               );
            _standardError.BaseStream.BeginRead(
               _errorBuffer, 0,
               _errorBuffer.Length,
               _errorReady,
               _errorState
               );
        }
        // event fires when text arrives on standard output or standard inpuy      
        public event CmdProcessorEventHandler TextReceived;
        // Initializes a ProcessStartInfo for the Process.
        protected virtual ProcessStartInfo GetStartInfo(string command) {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "miner.exe";
            // /c tells cmd.exe to execute the following command and then terminate
            psi.Arguments = command;
            // UseShellExecute = false required for stream redirection
            psi.UseShellExecute = false;
            // we will redirect standard streams to our own
            psi.RedirectStandardError = true;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            // dont allow the DOS box to appear
            psi.CreateNoWindow = true;
            return psi;
        }
        protected virtual Process InitializeProcess(string command) {
            if (_executing) {
                // don't allow client to start another process while one is 
                // currently executing
                throw new ApplicationException("A Process is currently executing");
            }
            _process = new Process();
            _process.StartInfo = GetStartInfo(command);
            _process.EnableRaisingEvents = true;
            _process.Exited += new EventHandler(_process_Exited);
            return _process;
        }
        private void AttachStreams() {
            _standardOutput = _process.StandardOutput;
            _standardError = _process.StandardError;
        }
        private void _process_Exited(object sender, EventArgs e) {
            int exitCode = _process.ExitCode;
            if (TextReceived != null) {
                // return exit code as part of output
                //TextReceived(
                //this,
                //new CmdProcessorEventArgs("Exited with code: " + exitCode.ToString())
                //);
            }
            _process.Dispose();
            _process = null;
            _executing = false;
        }

        // output has arrived on either standard output or standard error.
        // finish the asynch call, and if text has arrived raise an event.
        // finally, we need to try to read more from the steam in case not 
        // all the outout has arrived.
        private void OutputCallback(IAsyncResult ar) {
            AsyncState state = (AsyncState)ar.AsyncState;
            int count = state.Stream.BaseStream.EndRead(ar);
            if (count > 0) {
                if (TextReceived != null) {
                    string text = System.Text.Encoding.ASCII.GetString(state.Buffer, 0, count);
                    TextReceived(this, new CmdProcessorEventArgs(text));
                }
                state.Stream.BaseStream.BeginRead
                   (
                   state.Buffer, 0,
                   state.Buffer.Length,
                   _outputReady,
                   state
                   );
            }
        }
        // this method prepares the callback delegates which will be invoked when the 
        // asychronous reads have results, and also prepares a "state" object to carry
        // the stream and buffer objects used in the asynch calls
        private void PrepareAsyncState() {
            _outputReady = new AsyncCallback(OutputCallback);
            _outputState = new AsyncState(_standardOutput, _outputBuffer);
            _errorReady = new AsyncCallback(OutputCallback);
            _errorState = new AsyncState(_standardError, _errorBuffer);
        }
        private bool _executing = false;
        private Process _process;
        private StreamReader _standardOutput;
        private StreamReader _standardError;
        private byte[] _errorBuffer = new byte[512];
        private byte[] _outputBuffer = new byte[512];
        private AsyncCallback _outputReady;
        private AsyncState _outputState;
        private AsyncCallback _errorReady;
        private AsyncState _errorState;
    }
    public delegate void CmdProcessorEventHandler(object sender, CmdProcessorEventArgs e);
    public class CmdProcessorEventArgs:EventArgs {
        public CmdProcessorEventArgs(string text) {
            _text = text;
        }
        public string Output {
            get { return _text; }
            set { _text = value; }
        }
        protected string _text;
    }
    internal class AsyncState {
        public AsyncState(StreamReader stream, byte[] buffer) {
            _stream = stream;
            _buffer = buffer;
        }
        public StreamReader Stream {
            get { return _stream; }
        }
        public byte[] Buffer {
            get { return _buffer; }
        }
        protected StreamReader _stream;
        protected byte[] _buffer;
    }

}
