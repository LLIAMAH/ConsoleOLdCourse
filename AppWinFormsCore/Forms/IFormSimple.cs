using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinFormsCore.Forms
{
    public interface IFormSimple : IDisposable
    {
        DialogResult ShowDialog();
    }
}
