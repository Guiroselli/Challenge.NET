# Sistema de Rastreamento RFID de Motos - Mottu

Este projeto implementa uma API RESTful utilizando ASP.NET Core para o rastreamento de motos via RFID nos pátios da Mottu.

## Visão Geral

O sistema permite o rastreamento em tempo real de motos nos pátios da Mottu através de etiquetas RFID. Cada moto recebe uma etiqueta RFID passiva, e antenas/leitores RFID são instalados em pontos estratégicos do pátio. Quando uma moto passa por um ponto de leitura, o sistema registra a tag da moto, data/hora e localização, atualizando a posição da moto no sistema.

## Tecnologias Utilizadas

- ASP.NET Core 8.0
- Entity Framework Core 8.0
- Oracle Database
- Swagger/OpenAPI
- AutoMapper
- JWT para autenticação

## Estrutura do Projeto

O projeto segue uma arquitetura limpa (Clean Architecture) com as seguintes camadas:

- **MottuRFID.API**: Camada de apresentação com controllers e configuração do Swagger
- **MottuRFID.Application**: Camada de aplicação com DTOs, serviços e mapeamentos
- **MottuRFID.Domain**: Camada de domínio com entidades e interfaces de repositórios
- **MottuRFID.Infrastructure**: Camada de infraestrutura com implementação de repositórios e contexto do EF Core

## Modelo de Dados

O sistema possui as seguintes entidades principais:

- **Moto**: Representa as motocicletas rastreadas
- **Filial**: Representa as filiais da Mottu onde os pátios estão localizados
- **PontoLeitura**: Representa os pontos onde as antenas/leitores RFID estão instalados
- **LeituraRFID**: Representa os eventos de leitura RFID quando uma moto passa por um ponto

## Endpoints da API

### Motos
- `GET /api/motos` - Listar todas as motos (com filtros)
- `GET /api/motos/{id}` - Obter detalhes de uma moto específica
- `GET /api/motos/tag/{tagRFID}` - Obter moto por tag RFID
- `GET /api/motos/filial/{filialId}` - Listar motos por filial
- `POST /api/motos` - Cadastrar nova moto
- `PUT /api/motos/{id}` - Atualizar dados de uma moto
- `DELETE /api/motos/{id}` - Remover uma moto do sistema

### Filiais
- `GET /api/filiais` - Listar todas as filiais
- `GET /api/filiais/{id}` - Obter detalhes de uma filial específica
- `GET /api/filiais/{id}/motos` - Listar motos de uma filial
- `GET /api/filiais/{id}/pontosleitura` - Listar pontos de leitura de uma filial
- `POST /api/filiais` - Cadastrar nova filial
- `PUT /api/filiais/{id}` - Atualizar dados de uma filial
- `DELETE /api/filiais/{id}` - Remover uma filial

### Pontos de Leitura
- `GET /api/pontosleitura` - Listar todos os pontos de leitura
- `GET /api/pontosleitura/{id}` - Obter detalhes de um ponto de leitura específico
- `GET /api/pontosleitura/filial/{filialId}` - Listar pontos de leitura por filial
- `GET /api/pontosleitura/{id}/motos` - Listar motos em um ponto de leitura específico
- `POST /api/pontosleitura` - Cadastrar novo ponto de leitura
- `PUT /api/pontosleitura/{id}` - Atualizar dados de um ponto de leitura
- `DELETE /api/pontosleitura/{id}` - Remover um ponto de leitura

### Leituras RFID
- `GET /api/leiturasrfid` - Listar todas as leituras RFID (com filtros)
- `GET /api/leiturasrfid/{id}` - Obter detalhes de uma leitura específica
- `GET /api/leiturasrfid/moto/{motoId}` - Listar leituras de uma moto específica
- `GET /api/leiturasrfid/pontoleitura/{pontoId}` - Listar leituras de um ponto específico
- `POST /api/leiturasrfid` - Registrar nova leitura RFID
- `DELETE /api/leiturasrfid/{id}` - Remover uma leitura (apenas para fins administrativos)

## Instalação e Configuração

### Pré-requisitos
- .NET SDK 8.0 ou superior
- Oracle Database
- Visual Studio 2022 ou VS Code

### Passos para Instalação

1. Clone o repositório
   ```
   git clone https://github.com/seu-usuario/MottuRFID.git
   ```

2. Configure a string de conexão com o Oracle no arquivo `appsettings.json`
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "User Id=seu_usuario;Password=sua_senha;Data Source=seu_datasource;"
   }
   ```

3. Execute as migrações para criar o banco de dados
   ```
   dotnet ef database update
   ```

4. Execute o projeto
   ```
   dotnet run --project MottuRFID.API
   ```

5. Acesse a documentação da API em `https://localhost:5001/swagger`

## Uso da API

### Autenticação
A API utiliza autenticação JWT. Para obter um token, faça uma requisição POST para `/api/auth/login` com as credenciais de usuário.

### Exemplo de Requisição
```http
POST /api/leiturasrfid
Content-Type: application/json
Authorization: Bearer seu_token_jwt

{
  "tagRFID": "RF123456",
  "pontoLeituraId": 1,
  "dataHoraLeitura": "2025-05-19T14:30:00Z"
}
```

## Licença
Este projeto está licenciado sob a licença MIT.
