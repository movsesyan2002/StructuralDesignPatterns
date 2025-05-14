// // You are building a 2D shooter game.
// //  Thousands of bullets are fired by players and enemies every second.
// // ✅ Each bullet type shares:
// // Appearance (image/sprite)

// // Damage value

// // ✅ Each bullet instance has unique:
// // Position (x, y)

// // Direction (angle)

// // Speed

// // You must use the Flyweight Pattern to avoid creating thousands of heavy objects.
// //  ✅ Share bullet types through a BulletTypeFactory.
// // ✅ Store position, direction, speed externally.

// // 🛠 Tasks:
// // Create an interface BulletType:

// // Intrinsic data: sprite name, damage value

// // Method render(x: number, y: number, direction: number): void

// // Create a concrete class ConcreteBulletType implementing BulletType.

// // Create a BulletTypeFactory:

// // Reuse ConcreteBulletType objects by sprite name + damage combination.

// // Create a Bullet class:

// // Holds extrinsic data:

// // Position (x, y)

// // Direction (angle)

// // Speed

// // Holds a reference to a BulletType.


interface IBulletType {
    string SpriteName { get; set; }
    int Damagevalue { get; set; }

    void render(int x, int y, int direction);

}


class ConcreteBulletType : IBulletType {

    public string SpriteName { get; set; }
    public int Damagevalue { get; set;}


    public void render (int x, int y, int direction) {

        Console.WriteLine($"Drawing {SpriteName} bullet at ({x}, {y}) heading {direction} damage {Damagevalue}");
    
    }

}


class BulletTypeFactory {



}

class BulletType {



}
