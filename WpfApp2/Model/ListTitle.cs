using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WpfApp2.Model
{
    class ListTitle : ObservableCollection<Title>
    {
        public ListTitle()
        {
            DbSet<Title> titles = PageEmployee.DataEntitiesEmployee.Title;
            var queryTitle = from title in titles select title;
            foreach (Title titl in queryTitle)

                this.Add(titl);
        }
    }
}
