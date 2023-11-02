//Tallest Mountain
interface Mountain {
    name: string;
    height: number;
  }
const mountains: Mountain[] = [
    { name: 'Kilimanjaro', height: 19341 },
    { name: 'Everest', height: 29029 },
    { name: 'Denali', height: 20310 },
  ];
function findNameOfTallestMountain(mountainArray:Mountain[]): string {
    let highestMountain:string = "";
    let height:number = 0;

    for (let i = 0; i < mountainArray.length; i++){
        if(mountainArray[i].height > height){
            height = mountainArray[i].height;
            highestMountain = mountainArray[i].name;
        }
    }
    return highestMountain;
}
const tallestMountain:string = findNameOfTallestMountain(mountains);
console.log(tallestMountain);

//Products
interface Product {
  name: string;
  price: number;
}
const products: Product[] = [
  { name: 'Oxygen', price: 1000 },
  { name: 'Cat', price: 500 },
  { name: 'Battlestar Galactica', price: 100 },
];
function calcAverageProductPrice(productArray: Product[]): number {
  let totalPrice:number = 0;

  for (let i = 0; i < productArray.length; i++){
    totalPrice += productArray[i].price;
  }
  return totalPrice / productArray.length;
}
const averageProductPrice: number = calcAverageProductPrice(products);
console.log(averageProductPrice);

//Inventory
interface InventoryItem {
  product: Product;
  quantity: number;
}
const inventory: InventoryItem[] = [
  { product: { name: 'motor', price: 10.00 }, quantity: 10 },
  { product: { name: 'sensor', price: 12.50 }, quantity: 4 },
  { product: { name: 'LED', price: 1.00 }, quantity: 20 },
];
function calcInventoryValue(invArray: InventoryItem[]): number {
  let totalValue: number = 0;

  for (let i = 0; i < invArray.length; i++){
    totalValue += (invArray[i].product.price * invArray[i].quantity);
  }
  return totalValue;
}
const inventoryValue: number = calcInventoryValue(inventory);
console.log(inventoryValue);