using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace MvvmBase.Helper
{
  public static class ZhuanTaiThreadPool
  {
    /// <summary>
    /// Spawn this action in a background thread if we are not in the DLL mode
    /// </summary>
    /// <param name="i_Action"></param>
    public static void QueueUserWorkItem(Action i_Action)
    {
      ThreadPool.QueueUserWorkItem(i_State => i_Action());
    }


    public static void DoAsyncWork(Action i_Work, Action i_Complete)
    {
      DoWorker worker = new DoWorker(i_Work, i_Complete);
      worker.DoWork();
    }

  }

  public class DoWorker
  {
    private BackgroundWorker mWorker = null;
    private Action mWorkAction = null;
    private Action mWorkCompletedAction = null;

    public DoWorker(Action i_WorkAction, Action i_WorkCompletedAction)
    {
      mWorkAction = i_WorkAction;
      mWorkCompletedAction = i_WorkCompletedAction;

      mWorker = new BackgroundWorker();
      mWorker.DoWork += new DoWorkEventHandler(mWorker_DoWork);
      mWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(mWorker_RunWorkerCompleted);
    }

    public void DoWork()
    {
      mWorker.RunWorkerAsync();
    }

    private void mWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      if (mWorkAction != null)
      {
        mWorkAction();
      }
    }

    private void mWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (mWorkCompletedAction != null)
        mWorkCompletedAction();
    }

  }
}
