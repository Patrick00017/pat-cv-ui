using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ObjectDetectionModel
    {
        public string ModelID { get; set; }
        public string ModelName { get; set; }
        public string ModelDescription { get; set; }
        public string OnnxPath { get; set; }
    }
}
