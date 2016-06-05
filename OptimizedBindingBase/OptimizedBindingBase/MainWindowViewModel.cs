using System.Windows;
using OptimizedBindingBase.Base;

namespace OptimizedBindingBase
{
    public class MainWindowViewModel : BindingBaseOptimized
    {
        public string Name
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public int Count
        {
            get
            {
                return Get<int>();
            }

            set
            {
                if (Set(value))
                {
                    MessageBox.Show("Count was changed");
                }
            }
        }
    }
}
