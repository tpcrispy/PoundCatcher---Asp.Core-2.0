using PoundCatcher.Models.Dogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoundCatcher.Models.DogViewModels
{
    public class BasicDogList
    {
        public IEnumerable<BasicDogModel> BasicDogListView { get; set; }
    }
}
