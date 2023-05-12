#Enunciado do exercício

###1- Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e potencia com os tipos de dados string, string, string, int e int. Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”

a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110

b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120

c- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar para cada objeto

d- Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro.

e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos : modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)

f- Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o método Acelerar passando o valor do argumento para o parâmetro no método Acelerar

g- Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não use a palavra-chave this)

i- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que vai retornar um double representando a velocidade máxima do carro ( Para calcular a velocidade multiplique a potencia por 1.75)

j- Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a potência incremente 3 ao parâmetro recebido)

k- Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o comportamento da passagem do argumento por valor

l- Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a potência incremente 5 ao parâmetro recebido)

m- Invocar o método e passar o valor do argumento por referência e exibir os valores.

n- Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int como valor da nova potência. Neste método use parâmetro out e passe a variável velocidade e que vai retornar a nova velocidade como um double. (incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)

o- Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade.
