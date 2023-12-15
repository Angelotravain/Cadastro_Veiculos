# Desafio do Desenvolvedor C# - Aplicativo de Cadastro de Veículos

## Resumo do Projeto
O objetivo deste desafio é desenvolver um aplicativo desktop em C# utilizando Windows Forms (não .NET Framework). O aplicativo será responsável por cadastrar e listar veículos, permitindo a filtragem por marca específica e exibindo os modelos correspondentes.

## Recursos Obrigatórios
- Windows Forms (.NET - não .NET Framework)
- Sistema de Login com validação via API
- Tela inicial listando veículos
- Telas para realizar operações CRUD (Create, Read, Update, Delete) de veículos
- Criação do schema do banco MySQL para armazenamento dos dados cadastrados

## Práticas Recomendadas
- Utilização de Clean Code
- Organização do código em camadas (Models, Data, Services, Views)

## Fluxo do Aplicativo
1. O usuário realiza o login, com validação pela API de login.
2. Em caso de sucesso, é direcionado para a tela inicial que lista todos os veículos.
3. Nessa tela, o usuário pode adicionar, editar, excluir ou visualizar os registros.

## Campos de Cadastro de Veículos
- Placa
- Chassi
- Marca
- Modelo
- Ano de Fabricação
- Ano do Modelo
- Valor da Tabela FIPE
- Valor de Venda
- Observações

## Consumo de APIs
### Login
- **URL:** [https://test-api-y04b.onrender.com/signIn](https://test-api-y04b.onrender.com/signIn)
- **Método:** POST
- **Parâmetros no Body:** user e password
- **Credenciais de Teste:** User: teste / Password: 123
- **Retorno para Sucesso:**
- **Retorno para Erro:**

### Marcas
- **URL:** [https://parallelum.com.br/fipe/api/v1/carros/marcas](https://parallelum.com.br/fipe/api/v1/carros/marcas)
- **Método:** GET
- **Retorno:** Código e Nome

### Modelos
- **URL:** [https://parallelum.com.br/fipe/api/v1/carros/marcas/{código da marca}/modelos](https://parallelum.com.br/fipe/api/v1/carros/marcas/{código da marca}/modelos)
- **Exemplo:** [https://parallelum.com.br/fipe/api/v1/carros/marcas/59/modelos](https://parallelum.com.br/fipe/api/v1/carros/marcas/59/modelos)
- **Método:** GET
- **Retorno:** Código e Nome

## Avaliação
O projeto será avaliado com base nos seguintes critérios:
- Organização do projeto
- Boas práticas de programação
- Tratamento de erros e exceções

## Entrega
Você deve publicar o desafio em um repositório público do GitHub e enviar o link para o seguinte WhatsApp: 49 9 8890-9021.
