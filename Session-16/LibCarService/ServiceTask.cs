using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class ServiceTask
    {
        public enum CodeEnum {
            OilChange,
            TireChange,
            BrokenWindow,
            EngineChange,
            MirrorReplacement

        }
        public Guid ID { get; set; }

        public string Description { get; set; }

        public decimal Hours { get; set; }
        public CodeEnum Code { get; set; }


        public ServiceTask() {
            ID = Guid.NewGuid();
        }

        public ServiceTask(CodeEnum code)
        {
            ID = Guid.NewGuid();
            UpdateInfo(code);
        }

        // TODO: Method to update description and hours from Code
        public void UpdateInfo(CodeEnum code) {
            switch (code) {
                case CodeEnum.OilChange:
                    Description = "Change the oils";
                    Hours = 1.5M;
                    break;
                case CodeEnum.TireChange:
                    Description = "Change the tire";
                    Hours = 2.5M;
                    break;
                case CodeEnum.BrokenWindow:
                    Description = "Fix the broken window";
                    Hours = 1.25M;
                    break;
                case CodeEnum.EngineChange:
                    Description = "Change the engine";
                    Hours = 5;
                    break;
                case CodeEnum.MirrorReplacement:
                    Description = "Replace the mirror";
                    Hours = 0.5M;
                    break;
                default:
                    break;
            }

        }
    
    }
}
