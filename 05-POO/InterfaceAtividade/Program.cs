using InterfaceAtividade;

SalvarJson json = new();
json.Salvar();
json.Nome();



SalvarXML xml = new();
xml.Salvar();
xml.Nome();


ISalvar salvarcompactar = new SalvarJson();
salvarcompactar.Compactar();


