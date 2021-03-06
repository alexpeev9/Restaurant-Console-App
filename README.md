# Restaurant-Console-App

**Функционалност**: Проектът представлява конзолно приложение, което следи поръчки на клиенти в рестурант. 
В началото на деня (Когато приложението се пусне), Кухнята добавя продукти които ще се предлагат днес.
Например:\
**AddProduct DiavoloPizza**\
**AddProduct CapricciosaPizza**\
Има и други класове(Които също са продукти от кухнята) но днес кухнята ще готви само тези избраните от тях.
Когато клиент пристигне за поръчка той ще бъде вкаран в програмата като: \
**AddClient Client Alex**\
След като клиентът е вкаран в системата ще може да поръчва избрани продукти\
**AddProductToClient DiavoloPizza Alex  \
AddProduct CapricciosaPizza**\
Ако нещо не му харесва то той може да го махне.\
**RemoveProductFromClient CapricciosaPizza Alex **\
Той по всяко време може да види неговият инвентар с поръчки и сумата която дължи\
**ShowInventory Alex** \
За да се спре приложението е нужно да се напише \
**Exit**

## Commands
	AddClient {Type-of-Client} {Name-of-Client}
	AddProduct {Name-of-Product}
	AddProductToClient {Name-of-Product} {Name-of-Client}
	RemoveProductFromClient {Name-of-Product} {Name-of-Client}
	ShowInventory {Name-of-Client}
	Exit

Обяснение по код:
Приложението се стартира от главният клас StartUp. В класът имаме DI container в който са дефинирани всички Service-и. В Main методът извикваме класът Engine който е ядрото на програмата. Методът Engine.Run съдържа безкраен while цикъл който никога няма да спре, освен ако не бъде спрян с командата - Exit. Потребителят е длъжен да напише съобщение на конзолата и да го изпрати. След това кодът продължава в CommandInterpreter. В него според това каква команда и от какво се нуждаем ни отвежда на определена команда и ни зарежда определените service-и. 

Използвани са 
Interpreter, Command, Factory, Mediator, Observer design patterns.

Проектът е разделен на няколко подпапки.
Models,
Repositories,
Factories,
Comands,
Utilities,
Core.

В Utilities се намира класът Validator, който валидира input и output-ът на приложението.
Extensions: Microsoft.Extensions.DependencyInjection 3.1.14