using System;

class Program {
  static string[,] board = new string[,]
            {
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"}
            };

  static void Main(string[] args)
  {
      play();
  }

  static void play()
  {
      String box = null;
      String sign = null;
      int i = 0;
      Console.WriteLine("Welcome to the game!\n");
      do
      {
          printBoard();
          Console.WriteLine("\nPress 0 to exit the game, otherwise please enter the box number you want to play with:\n");
          box = Console.ReadLine();
          Console.WriteLine("\nPlease enter your sign:\n");
          sign = Console.ReadLine();
          Console.WriteLine("");

          switch (box)
          {
              case "1":
                  setValue(box, sign);
                  break;
              case "2":
                  setValue(box, sign);
                  break;
              case "3":
                  setValue(box, sign);
                  break;
              case "4":
                  setValue(box, sign);
                  break;
              case "5":
                  setValue(box, sign);
                  break;
              case "6":
                  setValue(box, sign);
                  break;
              case "7":
                  setValue(box, sign);
                  break;
              case "8":
                  setValue(box, sign);
                  break;
              case "9":
                  setValue(box, sign);
                  break;
              case "0":
                  Console.WriteLine("Game over");
                  break;
              default:
                  Console.WriteLine("Invalid box number!\n");
                  break;
          }

          Console.WriteLine("Winner detected: " + Checker(board));

          if (Checker(board))
          {
              break;
          } else if (box == "0")
          {
              break;
          }

          i++;
      } while (i <= board.Length);
  }

  static void setValue(string box, string sign)
  {
      for (int i = 0; i < board.GetLength(0); i++)
      {
          for (int j = 0; j < board.GetLength(0); j++)
          {
              if (board[i, j] == box)
              {
                  board[i, j] = sign;
              }
          }
      }
  }

  static void printBoard()
  {
      for(int i = 0; i < board.GetLength(0); i++)
      {
          for(int j = 0; j < board.GetLength(0); j++)
          {
              Console.Write(board[i, j] + " ");
          }
          Console.WriteLine("");
      }
  }

  static bool Checker(string[,] board)
  {
      // TODO
      // Caso horizontal
      int player1 = 0;
      int player2 = 0;

      for (int a = 0; a < board.GetLength(0); a++)
      {
          for (int b = 0; b < board.GetLength(0); b++)
          {
              if (board[a, b] != "X" && board[a, b] != "O")
              {
                  continue;
              }
              else if (board[a, b] == "X")
              {
                  player1 += 1;
              }
              else
              {
                  player2 += 1;
              }
          }
          if (player1 == 3 || player2 == 3)
          {
              Console.WriteLine("Caso horizontal");
              return true;
          }
          else
          {
              player1 = 0;
              player2 = 0;
          }
      }

      // Caso vertical
      for (int i = 0; i < board.GetLength(0); i++)
      {
          for (int j = 0; j <= board.Rank; j++)
          {
              if (board[j, i] != "X" && board[j, i] != "O")
              {
                  continue;
              }
              else if (board[j, i] == "X")
              {
                  player1 += 1;
              }
              else
              {
                  player2 += 1;
              }
          }
          if (player1 == 3 || player2 == 3)
          {
              Console.WriteLine("Caso vertical");
              return true;
          }
          else
          {
              player1 = 0;
              player2 = 0;
          }
      }

      // Caso diagonal a la derecha
      for (int i = 0; i < board.GetLength(0); i++)
      {
          for (int j = 0; j < board.GetLength(0); j++)
          {
              if (i != j || (board[i, j] != "X" && board[i, j] != "O"))
              {
                  continue;
              }
              else if (board[i, j] == "X")
              {
                  player1 += 1;
              }
              else
              {
                  player2 += 1;
              }
          }
          if (player1 == 3 || player2 == 3)
          {
              Console.WriteLine("Caso diagonal a la derecha");
              return true;
          }
      }

      player1 = 0;
      player2 = 0;

      // Caso diagonal a la izquierda
      for (int i = board.GetLowerBound(0), j = board.GetUpperBound(0); i < board.GetLength(0); i++, j--)
      {
          if (board[i, j] != "X" && board[i, j] != "O")
          {
              continue;
          }
          else if (board[i, j] == "X")
          {
              player1 += 1;
          }
          else
          {
              player2 += 1;
          }
          if (player1 == 3 || player2 == 3)
          {
              Console.WriteLine("Caso diagonal a la izquierda");
              return true;
          }
      }
      Console.WriteLine("No winner");
      return false;
  }
}