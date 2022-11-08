# Tarefas
<h1>Contexto</h1>
Construção de  um sistema gerenciador de tarefas, onde você poderá cadastrar uma lista de tarefas que permitirá organizar melhor a sua rotina.

Essa lista de tarefas possui um CRUD, ou seja, ela permite que você obtenha os registros, criar, salvar e deletar esses registros.

A aplicação  é do tipo Web API, utilizando Swagger para testar a aplicação.

A classe principal, a classe de tarefa, tem as seguintes informações:

<div>
    <img src="https://github.com/digitalinnovationone/trilha-net-api-desafio/blob/main/diagrama.png" title="HTML5"/>&nbsp;
</div>

# Métodos

Post -> O método de criação de uma tarefa, na qual recebe um body do swagger e salva no Banco de Dados.

Put -> O método  de alteração total de uma determinada tarefa. Para saber qual a tarefa, tem que ser recebido o Id da tarefa equivalente e confimar se ele existe no 
Banco de dados ou não. Caso exista, ele receberá um body e alterará as informações presentes naquela tarefa. Caso não exista, deverá ser retornado um NotFound com uma
Mensagem de aviso.

Delete -> O método de exclusão de uma tarefa. Para saber qual a tarefa excluída, será passado um Id da tarefa e, após verificar se existe, é excluído do banco de dados.
Caso não exista, é retornado um NotFound com uma mensagem.

Get -> O método que busca trazer alguma tarefa baseado em alguma busca por uma variável. O sistema pode possuir alguns gets, como:
  * Get (All) -> retornar todas as tarefas registradas no banco de dados.
  * Get (ObterPorId) -> retorna uma tarefa com o Id condizente ao que você está busando.
  * Get (ObterPorTitulo) -> retona uma tarefa baseado no título buscado.
  * Get (ObterPorData) -> retorna uma tarefa baseado na data desejada.
  * Get (ObterPorStatus) -> retorna uma tarefa baseado nos seus status. Ele pode ser pendente ou finalizado.
  

O sistema no swagger fica assim: 
<div>
  <img src="https://github.com/digitalinnovationone/trilha-net-api-desafio/blob/main/swagger.png" title="HTML5"/>&nbsp;
</div>
