using Raylib_cs;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;


Raylib.InitWindow(1000, 800, "Hello");
Raylib.SetTargetFPS(60);

int x = 0;
int carX = 1000;
int car2X = 1000;
int car3X = 1000;

Vector2 position = new Vector2(400 ,300);
Vector2 movement = new Vector2(2 ,1);
Color hotpink = new Color(255, 105, 180, 255);

Texture2D explosionImage = Raylib.LoadTexture("Explosion.png");
Texture2D characterImage = Raylib.LoadTexture("PixelFrooge.png");
Rectangle characterRect = new Rectangle(10, 10, 60, 60);
characterRect.width = characterImage.width;
characterRect.height = characterImage.height;
explosionImage.width = 200;
explosionImage.height = 100;

while (!Raylib.WindowShouldClose())
{
//   if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
//   {
  
//   position = new Vector(2, 0 ,0);
// }
    // position += movement;

characterRect.x += movement.X;
characterRect.y += movement.Y;


    x++;
    carX--;
    car2X -= 5;
    car3X -= 2;
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.DARKPURPLE);

// Raylib.DrawCircle(x, 300, 30, Color.WHITE);
// Raylib.DrawCircle(x, 300, 10, Color.BLACK);

// Raylib.DrawTriangle(x, 280, 100, Color.BEIGE);

// Raylib.DrawCircleV(position, 200, hotpink);

if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
{
x += 30;
}

if (x >= 1000)
{
x = -30;
}

if (carX <= 0)
{
carX = 1030;
}

if (car2X <= 0)
{
car2X = 1030;
}

if (car3X <= 0)
{
car3X = 1030;
}

Raylib.DrawRectangle(x + 20, 260, 5, 20, Color.GRAY);
Raylib.DrawRectangle(x, 280, 30, 10, Color.DARKGRAY);
Raylib.DrawRectangle(x + 20, 290, 5, 20, Color.GRAY);


Raylib.DrawRectangle(500, 200, 200, 900, Color.GRAY);
Raylib.DrawRectangle(200, 200, 200, 900, Color.DARKGRAY);


Raylib.DrawRectangle(0, 750, 1000, 100, Color.BLACK);

Raylib.DrawRectangle(carX, 760, 30, 10, Color.GRAY);
Raylib.DrawRectangle(carX + 8, 755, 15, 5, Color.GRAY);

Raylib.DrawRectangle(car3X, 760, 30, 10, Color.DARKGRAY);
Raylib.DrawRectangle(car3X + 8, 755, 15, 5, Color.DARKGRAY);

Raylib.DrawRectangle(car2X, 768, 30, 10, Color.GRAY);
Raylib.DrawRectangle(car2X + 8, 763, 15, 5, Color.GRAY);


if ( 400 >= x && x >= 170 || 700 >= x && x >= 470)
{


Raylib.DrawTexture(explosionImage, x - 75, 220, Color.WHITE);

// Raylib.DrawCircle(x + 5, 300, 50, Color.ORANGE);
// Raylib.DrawCircle(x + 5, 300, 5, Color.RED);
// Raylib.DrawCircle(x, 325, 5, Color.RED);
// Raylib.DrawCircle(x - 20, 310, 5, Color.RED);
// Raylib.DrawCircle(x + 10, 280, 5, Color.RED);
// Raylib.DrawCircle(x - 10, 298, 5, Color.RED);
// Raylib.DrawCircle(x + 23, 317, 5, Color.RED);
}

  Raylib.DrawTexture(characterImage, (int) characterRect.x, (int) characterRect.y, Color.WHITE);




  Raylib.EndDrawing();
}