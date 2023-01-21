# Dicionário
Este projeto é uma aplicação de console que permite o usuário adicionar termos e definições a um dicionário e realizar buscas de termos específicos. Os termos e definições são salvos em um arquivo JSON.

## Funcionalidades
- Adicionar termos e definições ao dicionário
- Procurar termos específicos no dicionário
- Ver todos os termos e definições no dicionário

### Enunciado
```
Você foi contratado pela escola de idiomas “Let’s Speak” para a construção de uma aplicação de dicionário para os alunos.
A aplicação deve ser construída conforme os requisitos a seguir.

A aplicação deve armazenar termos e seus significados. Os termos podem ser compostos de uma ou mais palavras
(como, por exemplo, no caso de phrasal verbs e expressões idiomáticas).

A aplicação deve permitir que o aluno insira novos termos sempre que julgar necessário. 
A aplicação deve permitir a busca de termos, não havendo distinção entre maiúsculas e minúsculas.
A busca deve ser feita apenas nos termos (não deve fazer buscas nas definições). 
Quando nenhum termo correspondente à busca for encontrado, a aplicação deve exibir na tela a mensagem “Nenhum termo encontrado”.
Caso contrário, devem ser exibidos todos os termos que correspondem à palavra buscada.
A aplicação não deve aceitar Wildcards (* e ?), a busca será feita usando-se somente palavras inteiras ou parte de palavras.
Por exemplo, ao buscar por pea, o sistema deve retornar termos como speak, pear, peacock, spears, etc.
A aplicação deve salvar os dados em um arquivo no disco de forma que, ao ser iniciada, todos os termos salvos sejam carregados.

```



### Bibliotecas Utilizadas
Newtonsoft.Json
System.IO

### Autor
Eu mesmo, Lucas ^^
