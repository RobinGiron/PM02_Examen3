using System;
using System.Collections.Generic;
using System.Text;

namespace PM2E30300
{
    public interface ISearchPage
    {
        void OnSearchBarTextChanged(string text);
        event EventHandler<string> SearchBarTextChanged;
    }
}
