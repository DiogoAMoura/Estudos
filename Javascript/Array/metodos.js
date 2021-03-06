/* Transformando arrays em string //

const fruits = ["Banana", "Orange", "Apple", "Mango"];
const txt = fruits.toString();
console.log(txt)
*/

/* Transformando arrays em string, mas com um separador especifico //

const fruits = ["Banana", "Orange", "Apple", "Mango"];
const txt = fruits.join('*');
console.log(txt)
*/

/* Pop() e push() //

const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.pop(); //Remove Mango
console.log(fruits)
let x = fruits.pop(); x = Mango
fruits.push(x)//Coloca a Mango na última posição
console.log("\n",fruits)
*/

/* shift() 

const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.shift(); //Remove Banana da lista
ou
let x = fruits.shift();// x = Banana
*/

/* unshift() //Adiciona um item ao começo do array 

const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.unshift("Lemon");  
console.log(fruits)
*/

/* splice(quantos valores serão adicionados, quantos valores serão removidos, valores*) Adiciona dois itens ao array //


const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.splice(2, 0, "Lemon", "Kiwi");
console.log(fruits)

// Utilizando splice() para remover itens do array

const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.splice(0, 1);
console.log(fruits)
*/

/* Concatenação de arrays //

const arr1 = ["Cecilie", "Lone"];
const arr2 = ["Emil", "Tobias", "Linus"];
const arr3 = ["Robin", "Morgan"];
const myChildren = arr1.concat(arr2, arr3);
console.log(arr1)
*/

/* Slice() Corta partes de arrays / Nota: o slice sempre cria um novo array

const fruits = ["Banana", "Orange", "Lemon", "Apple", "Mango"];
const citrus = fruits.slice(1);
const citrusCitrus = fruits.slice(1, 3) //slice() com múltiplos argumentos
console.log(citrus)
*/

/* split() É um metodo de string, mas transforma sua separação em um array

/* Removedor
let txt = "1, 2, 3"
let myArray = txt.split(",")
console.log(myArray[1])
*/

/* join() É como o split(), mas ao contrário

let frase = "Testando o método split";
let palavras = frase.split(" ");
let novaFrase = palavras.join("")
console.log(novaFrase)
*/

/* Faz com que cada letra de um Array vire um elemento em um array

let string = "Diogo"
console.log(Array.from(string))
*/