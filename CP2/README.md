# Loja de Instrumentos Musicais (C# Windows Forms)

Checkpoint 2 - C# Development - FIAP (Engenharia de Software, 3ESPR).
Sistema desktop em Windows Forms (.NET 8) com as telas obrigatórias:

| Tela | Arquivo | Função |
|------|---------|--------|
| Splash | `Forms/SplashForm.cs` | Abertura com barra de carregamento |
| Menu | `Forms/MenuForm.cs` | Navegação principal |
| Venda de Instrumentos | `Forms/VendaForm.cs` | Lançamento de pedidos (carrinho, estoque, total) |
| Relatório de Vendas | `Forms/RelatorioForm.cs` | Listagem das vendas e itens de cada venda |

Cada tela segue o padrão do Windows Forms: `NomeForm.cs` (lógica e eventos) + `NomeForm.Designer.cs`
(controles, editáveis no Designer do Visual Studio).

Dados em `Services/Repositorio.cs` (catálogo fixo; vendas salvas em `vendas.json` ao lado do executável).

## Como executar
Requisitos: Windows, .NET 8 SDK (ou Visual Studio 2022).

```
dotnet run --project LojaInstrumentos.csproj
```

Ou abra `LojaInstrumentos.sln` no Visual Studio e pressione F5.

## Fluxo de trabalho (Git & GitHub)

1. Tech Lead cria a **organização** no GitHub e o repositório **público**.
2. Tech Lead adiciona todos os integrantes com permissão **Write**.
3. Tech Lead sobe este projeto na `main` (com `.gitignore`), cria a branch `dev` e distribui as tarefas.
4. Cada integrante: clona, cria uma branch por tarefa a partir da `dev` (ex.: `feature/tela-venda`),
   faz **no mínimo 3 commits semânticos por tarefa** e abre um **Pull Request para `dev`**.
5. Tech Lead revisa os PRs, pede correções se necessário e faz os merges.
6. Entrega: merge final `dev` → `main`, `integrantes.txt` preenchido na raiz (RMs, nomes, link do repositório),
   e o link + nomes + RMs postados em um `.txt` na tarefa do Teams.

### Sugestão de divisão de tarefas

| Integrante | Tarefa | Arquivos |
|------------|--------|----------|
| Tech Lead | Estrutura base, `.gitignore`, branches, revisão de PRs, `integrantes.txt` | `LojaInstrumentos.csproj`, `Program.cs`, `.gitignore` |
| Integrante 2 | Tela de Splash + Tela de Menu | `Forms/SplashForm.cs`, `Forms/MenuForm.cs` |
| Integrante 3 | Tela de Venda de Instrumentos | `Forms/VendaForm.cs` |
| Integrante 4 | Tela de Relatório + modelos e repositório | `Forms/RelatorioForm.cs`, `Models/`, `Services/` |

(Com 3 pessoas, junte as tarefas dos integrantes 3 e 4 conforme combinado.)

### Exemplos de commits semânticos (3 por tarefa)

```
feat(splash): cria tela de splash com barra de progresso
feat(splash): navega para o menu ao concluir o carregamento
style(splash): ajusta cores e fontes da tela
docs: adiciona instruções de execução ao README
fix(venda): valida estoque antes de adicionar item
test(relatorio): confere totais com vendas de exemplo
chore: configura .gitignore para .NET
```

Prefixos usuais: `feat`, `fix`, `docs`, `style`, `refactor`, `test`, `chore`.
