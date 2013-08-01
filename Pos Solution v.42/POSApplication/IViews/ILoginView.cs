using MVCSharp.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.IViews
{
    public interface ILoginView : IView
    {
        void UpdateView();
    }
}
