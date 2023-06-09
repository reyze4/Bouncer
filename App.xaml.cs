using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ShcoolLearn.Components.Model;

namespace ShcoolLearn
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static BouncerBDEntities1 DB = new BouncerBDEntities1();
        public static Client LoggedClient;
    }
}
