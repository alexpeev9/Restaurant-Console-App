# Restaurant-Console-App

Функционалност: Проектът представлява конзолно приложение, което следи поръчки на клиенти в магазин. 
В началото на деня (Когато приложението се пусне), Кухнята добавя продукти които ще се предлагат днес.
Например: 
@@AddProduct DiavoloPizza@@
@@AddProduct CapricciosaPizza@@
Има и други класове(Които също са продукти от кухнята) но днес кухнята ще готви само тези избраните от тях.
Когато клиент пристигне за поръчка той ще бъде вкаран в програмата като: 
@@AddClient Client Petar@@
След като клиентът е вкаран в системата ще може да поръчва избрани продукти
@@ AddProductToClient Petar DiavoloPizza @@
@@AddProduct CapricciosaPizza@@
Ако нещо не му харесва то той може да го махне.
@@ RemoveProductFromClient Petar CapricciosaPizza@@
Той по всяко време може да види неговият инвентар с поръчки и сумата която дължи
@@ ShowClientInventory Petar@@