using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayLily.CommonViews.ViewModels.Common
{
    public class NomenclatureModel
    {
        public string Name
        {
            get
            {
                return nameof(NomenclatureModel);
            }
        }
        public IEnumerable<NomenclatureItem> Items { get; set; } = new List<NomenclatureItem>();

        public NomenclatureModel()
        {
            for (int i = 0; i < 100; i++)
            {
                (Items as List<NomenclatureItem>).Add(new NomenclatureItem() { Name = $"_name{i.ToString("D3")}" });
            }
        }
      
    }

    public class NomenclatureItem
    {
        public string Name { get; set; }
        public string Description { get; set; } = "Test description";
        public override string ToString()
        {
            return $"Name: {Name}/{Description}";
        }
    }
}
