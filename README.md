# To-Do List em ASP.NET - Desafio de Estágio na Andritz

## Descrição do Projeto

Este é um projeto de To-Do List desenvolvido como parte do processo de estágio para a Andritz. O objetivo principal foi criar uma aplicação web utilizando ASP.NET, implementando uma arquitetura de três camadas, conforme especificado pela Andritz: UI, Service e Dados.

## Tecnologias Utilizadas

- **ASP.NET:** O framework ASP.NET foi escolhido para o desenvolvimento da aplicação web devido à sua robustez e eficiência.
- **Bootstrap:** A biblioteca Bootstrap foi utilizada para facilitar o design responsivo e melhorar a experiência do usuário na interface.
- **3 Camadas:**
  - **UI (Interface do Usuário):** Desenvolvida conforme as preferências pessoais, oferecendo uma experiência intuitiva e amigável ao usuário.
  - **Service (Web API):** Implementada para fornecer uma interface entre a camada de UI e a camada de dados, seguindo as melhores práticas para comunicação entre componentes.
  - **Dados:** Utilizando SQLite como o banco de dados preferencial, garantindo eficiência e simplicidade na persistência de dados.

## Funcionalidades Implementadas

1. **Adição de Tarefas:** Os usuários podem adicionar novas tarefas à lista.
2. **Edição de Tarefas:** Permite a edição de tarefas existentes para atualizar informações ou status.
3. **Exclusão de Tarefas:** Os usuários têm a capacidade de excluir tarefas concluídas ou não necessárias.
4. **Marcadores de Status:** As tarefas podem ser marcadas como concluídas, ajudando os usuários a acompanhar seu progresso.
5. **Listagem de Tarefas:** Exibição clara e organizada de todas as tarefas disponíveis, com opções de filtragem e ordenação.

## Como Executar o Projeto

1. Clone este repositório em sua máquina local.
   ```bash
   git clone https://github.com/jvolive/To_do_List.git
   ```

## Executando o Projeto

1. **Abra a solução no Visual Studio ou qualquer IDE de sua preferência que suporte ASP.NET.**

2. **Execute a aplicação.**

3. **Acesse a aplicação através do navegador utilizando o endereço local (geralmente, [http://localhost:porta](http://localhost:porta)).**

### Configuração do Banco de Dados

- O banco de dados SQLite já está incluído no projeto. Não é necessário configurar um servidor externo.
- Ao executar o projeto pela primeira vez, o banco de dados será criado automaticamente.
- Certifique-se de que as configurações de conexão estão corretas no arquivo `appsettings.json`.

### Observações

- Este projeto foi desenvolvido como parte do desafio de estágio para a Andritz e segue as diretrizes estabelecidas no processo seletivo.
- Caso tenha alguma dúvida ou sugestão de melhoria, sinta-se à vontade para entrar em contato.
- Agradecemos pela oportunidade e esperamos que o projeto atenda às expectativas estabelecidas!
