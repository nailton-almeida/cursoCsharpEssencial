# Enunciado do exercício

1. Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e potencia com os tipos de dados string, string, string, int e int. Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”

      1. Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110

      2. Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120

      3. Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar para cada objeto

      4. Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro.

      5. Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos : modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)

      6. Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o método Acelerar passando o valor do argumento para o parâmetro no método Acelerar

      7. Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não use a palavra-chave this)

      8. Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que vai retornar um double representando a velocidade máxima do carro ( Para calcular a velocidade multiplique a potencia por 1.75)

      9. Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a potência incremente 3 ao parâmetro recebido)

      10. Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o comportamento da passagem do argumento por valor

      11. Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a potência incremente 5 ao parâmetro recebido)

      12. Invocar o método e passar o valor do argumento por referência e exibir os valores.

      13. Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int como valor da nova potência. Neste método use parâmetro out e passe a variável velocidade e que vai retornar a nova velocidade como um double. (incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)

      14. Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade.

      15. Crie um método chamado ExibirInfo() que retorna void e que utiliza os parâmetros : Modelo, Montadora, Marca, Potencia e Ano e que exiba as informações destes atributos no console.

      16. Para este método defina o parâmetro Ano como opcional e faça duas chamadas ao método usando o conceito de argumentos nomeados não informando o ano na primeira chamada e informando o ano na segunda chamada.

      17. Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para todos os carros 
      
      18. Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva
        
      19. Acesse o valor do campo ValorIpva e exiba no console.

      20. Substituir na classe Carro o campo Ano por uma propriedade de mesmo nome e mesmo tipo.
      
      21. Validar a informação do Ano de forma que se o ano informado for menor que 2000 seja atribuído 2000 e se for informado maior que 2022 seja atribuído 2022 ao valor do ano

      22. Crie uma struct chamada Cliente e defina os campos Nome e Email do tipo string e a propriedade Idade do tipo int 
      
      23. Validar a informação da Idade de forma que se a idade informada for menor que 18 seja atribuído 18 ao valor da idade.
      
      24. Crie um construtor para a struct usando os campos Nome e Email e a propriedade Idade como parâmetros de entrada para criar um objeto do tipo Cliente
      
      25. Crie um método estático que retorne void chamado ExibirInfo que receba os parâmetros nome, email e idade e exiba as informações de Nome, Email e Idade. Defina idade como um parâmetro opcional.

      26. Crie um objeto cliente da struct Cliente usando o construtor criado e exiba as informações chamando duas vezes o método ExibirInfo usando argumentos nomeados. Na primeira chamada informe todos os parâmetros e na segunda não informe o ano.

      27. Crie uma enumeração chamada Cores em um arquivo CarroEnum.cs que defina os seguintes membros : Branco, Vermelho, Preto, Cinza, Prata e Azul
    * Inicie o valor da enumeração com 1
    * Inclua na classe Carro o campo Cor do tipo int que vai representar a cor do carro
    * Altere o construtor da classe incluindo o campo Cor para criar objetos usando a Cor selecionada
    * Defina um menu de opções exibindo o nome da Cor e o seu valor 
    * Receba a seleção do usuário em uma variável do tipo int cor que vai ser usada para atribuir ao campo Cor
    * Altere o método ExibirInfo() incluindo o parâmetro cor do tipo int como parâmetro opcional e exiba o nome da cor a partir do valor da Cor recebida
