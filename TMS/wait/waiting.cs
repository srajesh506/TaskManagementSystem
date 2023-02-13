using System.Threading;
using System.Windows.Forms;

namespace TMS.UI.Wait
{
    class Waiting
    {
        WaitForm wait;
        Thread loadThread;
        public void Show()
        {
            //loadthread
            loadThread = new Thread(new ThreadStart(LoadingProcess));
            loadThread.Start();
        }
        public void Show(Form parent)
        {
            loadThread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadThread.Start(parent);
        }
        public void Close()
        {
            if(wait!=null)
            {
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.CloseWaitForm));
                wait = null;
                loadThread = null;
            }

        }
        private void LoadingProcess()
        {
            wait = new WaitForm();
            wait.ShowDialog();
        }
        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new WaitForm(parent1);
            wait.ShowDialog(); 
        }
    }
   
}
