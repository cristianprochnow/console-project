class Clients
{
  private Screen screen;
  private List<ClientsData> data = new List<ClientsData>();

  public Clients(Screen screen)
  {
    this.screen = screen;

    this.data.Add(new ClientsData("1", "Xunda", "x@b.com", "123"));
    this.data.Add(new ClientsData("2", "Babalu", "b@b.com", "456"));
  }

  public void executeCRUD()
  {
    string id, name, email, phone;
    int initialColumn, initialRow;

    initialColumn = 10;
    initialRow = 8;

    this.buildScreen(initialColumn, initialRow);

    initialColumn += 11;

    Console.SetCursorPosition(initialColumn, initialRow + 2);
    id = Console.ReadLine();

    bool hasFound = false;
    for (int counter = 0; counter < this.data.Count; counter++)
    {
      if (this.data[counter].id == id) {
        hasFound = true;
        break;
      }
    }

    Console.SetCursorPosition(initialColumn, initialRow + 3);
    if (hasFound) {
      Console.Write("Código já registrado!");
    }
    else {
      Console.Write("Código ainda não usado!");
    }
    Console.ReadKey();
  }

  public void buildScreen(int initialColumn, int initialRow)
  {
    int finalColumn, finalRow;

    finalColumn = initialColumn + 40 + 1;
    finalRow = initialRow + 6 + 1;

    this.screen.buildFrame(initialColumn, initialRow, finalColumn, finalRow);
    this.screen.insert(initialColumn + 1, initialRow + 1, "Cadastro de Clientes");
    this.screen.insert(initialColumn + 1, initialRow + 2, "Código:        ");
    this.screen.insert(initialColumn + 1, initialRow + 3, "Nome:          ");
    this.screen.insert(initialColumn + 1, initialRow + 4, "Email:         ");
    this.screen.insert(initialColumn + 1, initialRow + 5, "Telefone:      ");
    this.screen.insert(initialColumn + 1, initialRow + 6, "Confirma (S/N):");
    Console.ReadKey();
  }
}
