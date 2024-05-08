using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkazyHalka
{
    internal class ozgedeneme
    {
        public static void AddItemsToListView(ListView listView)
        {
            // Assuming listView is the ListView control you want to populate
            listView.Items.Add(new ListViewItem(new[] { "Item 1", DateTime.Now.ToString() }));
            listView.Items.Add(new ListViewItem(new[] { "Item 2", DateTime.Now.AddDays(1).ToString() }));
            // Add more items as needed
        }

    }


}
