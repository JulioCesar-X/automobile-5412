# Sistema de Gerenciamento de Veículos Automotivos em C# com MVC Adaptado
Trata-se de um sistema de gerenciamento de veículos automotivos em C#, utilizando um conceito adaptado de MVC (Model-View-Controller) para organizar e estruturar o código.

# Funcionalidades Principais
**Inserir Novo Veículo (Model)**: Permite aos usuários inserir informações sobre um novo veículo. O Model é responsável por manipular os dados do veículo e realizar validações antes de inserir no sistema.

**Alterar Estado de um Veículo (Controller)**: Os usuários podem alterar o estado de um veículo, indicando se ele está disponível para aluguel, em manutenção ou qualquer outro estado relevante. O Controller é responsável por receber a solicitação do usuário e atualizar o estado do veículo no sistema.

**Ver Veículos Disponíveis para Aluguel (View)**: Esta funcionalidade permite visualizar todos os veículos disponíveis para aluguel, filtrados por tipo de veículo. A View é responsável por apresentar os dados dos veículos de forma organizada e amigável para o usuário.

**Ver Veículos em Manutenção (View)**: Os usuários podem visualizar todos os veículos que estão atualmente em manutenção. A View é responsável por apresentar os veículos em manutenção de forma clara e compreensível para o usuário.

**Calcular Preço de uma Reserva (Model/Controller)**: Esta funcionalidade permite calcular o preço de uma reserva, fornecendo a data de início e de término da reserva, juntamente com o veículo desejado. O Model é responsável por calcular o preço com base nas taxas de aluguel aplicáveis, enquanto o Controller é responsável por receber as informações da reserva e solicitar o cálculo do preço ao Model.

**Exportar Informações dos Veículos para um Arquivo CSV (Controller)**: Os usuários podem exportar as informações sobre os veículos para um arquivo CSV. O Controller é responsável por coordenar a geração do arquivo CSV com base nos dados do sistema.

# Estrutura de Arquivos (Conceito Adaptado de MVC)
Model: Contém as classes responsáveis por representar os dados e a lógica de negócios relacionada aos veículos.
View: Contém as interfaces gráficas responsáveis por apresentar os dados dos veículos aos usuários.
Controller: Contém as classes responsáveis por receber as entradas dos usuários, interagir com o Model e atualizar a View de acordo.
#Tecnologias Utilizadas
O sistema foi desenvolvido utilizando as seguintes tecnologias e recursos:

**Linguagem de Programação: C#**
**Interface Gráfica: Windows Forms (WinForms)**
**IDE: Visual Studio**

# Contribuição
Este projeto foi desenvolvido em grupo como parte da **UFCD 5412 do curso TPSIP da ATEC**. Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests ou abrir issues com sugestões, correções de bugs ou melhorias.
