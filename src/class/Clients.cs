class Clients
{
  private Screen screen;

  public Clients(Screen screen)
  {
    this.screen = screen;
  }

  public void executeCRUD()
  {
    this.buildScreen(10, 8);
  }

  public void buildScreen(int initialColumn, int initialRow)
  {
    int finalColumn, finalRow;

    finalColumn = initialColumn + 40 + 1;
    finalRow = initialRow + 6 + 1;

    this.screen.buildFrame(initialColumn, initialRow, finalColumn, finalRow);
    this.screen.insert(initialColumn + 1, initialRow + 1, "Cadastro de Clientes");
    Console.ReadKey();
  }
}
