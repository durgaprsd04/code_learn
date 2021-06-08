//using Microsoft.Win32.SafeHandles;
using System;
namespace CSharp.Basics
{
    //An option to do dispose is to call finalize on the class appending 
    //~Classname not recommend by microsfot use IDisposable instead
    // re implement the dispose, call dispose explicitly
    public class TestDispose:IDisposable
    {
        bool _property; 
        //private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);
        
        public void Dispose()
        {
            Dispose(true);
        }
        public virtual void Dispose(bool property)
        {
            if(_property)
                return ;
            //do Garbage collection here
            if (property)
            {
                // Dispose managed state (managed objects).
                //_safeHandle?.Dispose();
            }
            _property=true;
        }
        ~TestDispose()
        {
            Dispose(false);
        }
    }
}