using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiledBindingsSample
{
    public class BaseCoreContentPage : ContentPage
    {
       
    }

    public class CoreContentPage<T> : BaseCoreContentPage
        where T : BaseViewModel, new()
    {
        public T ContextedViewModel { get; set; }

        public CoreContentPage()
        {
            BindingContext = ContextedViewModel = new T();
        }
    }
}
