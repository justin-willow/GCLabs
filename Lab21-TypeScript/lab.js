var mountains = [
    { name: 'Kilimanjaro', height: 19341 },
    { name: 'Everest', height: 29029 },
    { name: 'Denali', height: 20310 },
];
function findNameOfTallestMountain(mountainArray) {
    var highestMountain = "";
    var height = 0;
    for (var i = 0; i < mountainArray.length; i++) {
        if (mountainArray[i].height > height) {
            height = mountainArray[i].height;
            highestMountain = mountainArray[i].name;
        }
    }
    return highestMountain;
}
var tallestMountain = findNameOfTallestMountain(mountains);
console.log(tallestMountain);
var products = [
    { name: 'Oxygen', price: 1000 },
    { name: 'Cat', price: 500 },
    { name: 'Battlestar Galactica', price: 100 },
];
function calcAverageProductPrice(productArray) {
    var totalPrice = 0;
    for (var i = 0; i < productArray.length; i++) {
        totalPrice += productArray[i].price;
    }
    return totalPrice / productArray.length;
}
var averageProductPrice = calcAverageProductPrice(products);
console.log(averageProductPrice);
var inventory = [
    { product: { name: 'motor', price: 10.00 }, quantity: 10 },
    { product: { name: 'sensor', price: 12.50 }, quantity: 4 },
    { product: { name: 'LED', price: 1.00 }, quantity: 20 },
];
function calcInventoryValue(invArray) {
    var totalValue = 0;
    for (var i = 0; i < invArray.length; i++) {
        totalValue += (invArray[i].product.price * invArray[i].quantity);
    }
    return totalValue;
}
var inventoryValue = calcInventoryValue(inventory);
console.log(inventoryValue);
