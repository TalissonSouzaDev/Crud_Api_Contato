
# DESCRIÇÃO

É uma API de contato para cadastra os contatos e verificar se esta ativo ou não Utilizando os melhores recursos do Entity Framework com banco de dados Sql Server


## API Contato

#### Retorna um item

```http
  GET /api/Contato/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do item que você quer |


```http
  GET /api/Contato/{name}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `name`      | `string` | **Obrigatório**. name do item que você quer |


```http
  POST /api/Contato/
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `Nome`      | `string` | **Obrigatório**. |
| `Telefone`      | `string` | **Obrigatório**.|
| `Ativo`      | `bool` | **Obrigatório**.|


```http
  PUT /api/Contato/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do item que você quer Atualizar |
| `Nome`      | `string` |  |
| `Telefone`      | `string` | |
| `Ativo`      | `bool` ||


```http
  DELETE /api/Contato/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do item que você quer excluir


## Recurso \ comando

Para rodar esse projeto, você vai precisa

`SQL SERVER`
Comando pra rodar
`dotnet watch run`

