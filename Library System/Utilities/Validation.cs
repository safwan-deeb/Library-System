using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class Validation
{
    public static bool IsValidTitle(string title)
    {
        return !string.IsNullOrWhiteSpace(title);
    }
}