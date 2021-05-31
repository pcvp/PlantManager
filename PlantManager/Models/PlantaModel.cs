using System;
using System.Collections.Generic;
using System.Text;

namespace PlantManager.Models {
    public class PlantaModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string UrlDaImagem { get; set; }
        public string DescricaoDaRega { get; set; }
        public List<AmbienteModel> PodeFicarNosAmbientes { get; set; }

        public PlantaModel(int id, string nome, string descricao, string descricaoDaRega, string urlDaImagem, List<AmbienteModel> podeFicarNosAmbientes) {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            DescricaoDaRega = descricaoDaRega;
            UrlDaImagem = urlDaImagem;
            PodeFicarNosAmbientes = podeFicarNosAmbientes;
        }
    }
}
