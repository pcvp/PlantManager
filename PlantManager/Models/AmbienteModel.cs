using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManager.Models {
    public class AmbienteModel {
        public int Id { get; set; }
        public string Nome { get; set; }

        public AmbienteModel(int id, string nome) {
            Id = id;
            Nome = nome;
        }
    }
}
