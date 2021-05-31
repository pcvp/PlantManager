using PlantManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManager.Mock {
    public class AmbienteMock {
        public List<AmbienteModel> Ambientes { get; set; }

        public AmbienteMock() {
            Ambientes = new List<AmbienteModel>();            
            Ambientes.Add(new AmbienteModel(1, "Quarto"));
            Ambientes.Add(new AmbienteModel(2, "Sala"));
            Ambientes.Add(new AmbienteModel(3, "Cozinha"));
            Ambientes.Add(new AmbienteModel(4, "Varanda"));
            Ambientes.Add(new AmbienteModel(5, "Quintal"));
        }
    }
}
