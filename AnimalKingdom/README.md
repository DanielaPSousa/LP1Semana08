# Diagram AnimalKingdom
```mermaid
classDiagram
    class Animal {
        <<abstract>>
    }
    class Dog {
    }
    class Cat {
    }
    class Bat {
    }
    class Bee {
    }
    class IMammal {
        <<interface>>
    }
    class ICanFly {
        <<interface>>
    }
    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Bat
    Animal <|-- Bee
    IMammal <|.. Dog
    IMammal <|.. Cat
    IMammal <|.. Bat
    ICanFly <|.. Bat
    ICanFly <|.. Bee
