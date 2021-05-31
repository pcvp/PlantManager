using PlantManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantManager.Mock {
    public class PlantaMock {
        public List<PlantaModel> Plantas { get; set; }

        public PlantaMock() {
            var ambientes = new AmbienteMock().Ambientes;
            Plantas = new List<PlantaModel>();

            Plantas.Add(new PlantaModel(1, "Violetas",
                "Um clássico dos lares brasileiros, você provavelmente já admirou uma bela violeta na casa de sua avó ou uma tia distante. Com flores delicadas e folhas de verde-escuro intenso, as violetas ficam bem em qualquer ambiente!",
                "É recomendado regar uma vez ao dia em dias mais quentes e uma vez a cada dois dias no inverno",
                "https://www.petz.com.br/blog/wp-content/uploads/2019/08/violeta.jpg",
                ambientes));


            Plantas.Add(new PlantaModel(2, "Cyclamen",
                "Outra planta para dentro de casa, o cyclamen também desperta atenção por sua beleza delicada. Originário do mediterrâneo, se espalhou pelo mundo e, hoje, é facilmente encontrado em lojas especializadas.",
                "Ela deve ser regada uma vez a cada dois dias nos meses mais quentes. Durante o inverno, uma vez por semana é o suficiente.",
                "https://www.petz.com.br/blog/wp-content/uploads/2019/08/cyclamen.jpg",
                ambientes.Where(a => a.Nome == "Quarto" || a.Nome == "Cozinha").ToList()));


            Plantas.Add(new PlantaModel(3, "Cyclamen",
                "Outra planta para dentro de casa, o cyclamen também desperta atenção por sua beleza delicada. Originário do mediterrâneo, se espalhou pelo mundo e, hoje, é facilmente encontrado em lojas especializadas.",
                "Ela deve ser regada uma vez a cada dois dias nos meses mais quentes. Durante o inverno, uma vez por semana é o suficiente.",
                "https://www.petz.com.br/blog/wp-content/uploads/2019/08/cyclamen.jpg",
                ambientes.Where(a => a.Nome == "Quarto" || a.Nome == "Cozinha").ToList()));

            Plantas.Add(new PlantaModel(4, "Suculentas",
                "Campeãs quando o assunto é fácil trato, as suculentas são perfeitas para quem adora ter um verde em casa mas não possui muito tempo para jardinagem. Estas plantas vêm em diferentes cores, formatos e tamanhos, agradando todos os gostos.",
                "Uma vez por semana em dias quentes e duas vezes por mês nas estações frias é o suficiente.",
                "https://www.petz.com.br/blog/wp-content/uploads/2019/08/suculentas.jpg",
                ambientes));

            Plantas.Add(new PlantaModel(5, "Jade",
                "Esta planta é muito versátil e vem em diferentes tamanhos: desde mini-vasos até grandes arbustos. Possui folhas de um verde intenso e brilhante. Seus galhos retorcidos dão um charme especial à jade.",
                "Está acostumada a climas áridos, e não precisa de muita água, uma vez por semana está de bom tamanho.",
                "https://www.petz.com.br/blog/wp-content/uploads/2019/08/jade.jpg",
                ambientes.Where(a => a.Nome == "Varanda" || a.Nome == "Quintal").ToList()));

            Plantas.Add(new PlantaModel(6, "Fitônia",
               "Também chamada planta-mosaico, a fitônia desperta atenção por sua beleza exótica. Sua folhagem colorida pode ter diferentes tons de rosa, avermelhado ou branco, em belos desenhos que lembram uma obra de arte. Elas gostam de muita luz e sol indireto, e preferem temperaturas mais altas.",
               "São nativas de florestas tropicais e gostam de muita umidade. Por isso, devem ser regadas diariamente.",
               "https://www.petz.com.br/blog/wp-content/uploads/2019/08/fitonia.jpg",
               ambientes.Where(a => a.Nome == "Varanda" || a.Nome == "Quintal").ToList()));

            Plantas.Add(new PlantaModel(7, "Cactos",
              "Se você deseja ter uma planta em casa, mas é muito ocupado ou um tanto distraído, os cactos podem ser a opção ideal. Naturais de climas áridos, eles são peritos quando o assunto é sobrevivência, e se adaptam aos mais diversos lugares.",
              " São acostumados com locais secos, por isso, devem ser regados apenas uma vez a cada 15 dias.",
              "https://www.petz.com.br/blog/wp-content/uploads/2019/08/cactos.jpg",
              ambientes.Where(a => a.Nome == "Varanda").ToList()));


            Plantas.Add(new PlantaModel(8, "Lírio da paz",
              "Evocando paz e tranquilidade, o lírio da paz é uma ótima ideia para plantas em ambientes internos. Apesar de sua beleza delicada, é de fácil trato e muito indicada para jardineiros iniciantes. Se cuidar bem de sua planta, ela irá retribuir com flores entre janeiro e março, e, entre julho e setembro.",
              "Deve ser regada três vezes por semana no verão e semanalmente em dias mais frios.",
              "https://www.petz.com.br/blog/wp-content/uploads/2019/08/lirio-da-paz.jpg",
              ambientes.Where(a => a.Nome == "Varanda").ToList()));

            Plantas.Add(new PlantaModel(9, "Árvore da felicidade",
            "Esta planta oriental conquistou o mundo com sua beleza singela e cheia de significado. Dizem que a árvore da felicidade traz fortuna para o lar, mas apenas se for ganhada. Deve ser mantida longe de luz direta ou muito calor.",
            "Gosta de água, deve ser regada três vezes por semana ou mais.",
            "https://www.petz.com.br/blog/wp-content/uploads/2019/08/arvore-da-felicidade.jpg",
            ambientes.Where(a => a.Nome == "Sala").ToList()));


           Plantas.Add(new PlantaModel(9, "Palmeira leque",
           "Uma das queridinhas dos decoradores, a palmeira leque se destaca por seu aspecto exótico e escultural! Também conhecida como licuala, é natural da Oceania e se adaptou perfeitamente em países de clima tropical. Elas gostam da luz da manhã, mas devem ser protegidas dos raios diretos do sol. ",
           "São plantas naturais de locais úmidos, por isso, devem ser regadas de uma a três vezes por semana.",
           "https://www.petz.com.br/blog/wp-content/uploads/2019/08/palmeira-leque.jpg",
           ambientes.Where(a => a.Nome == "Quintal").ToList()));
        }
    }
}
