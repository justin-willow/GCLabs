class Country {
    constructor(name, lang, greeting, colors) {
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
    }
    displayColors() {
        document.getElementById("Color1").style.backgroundColor = this.colors[0];
        document.getElementById("Color2").style.backgroundColor = this.colors[1];
        document.getElementById("Color3").style.backgroundColor = this.colors[2];

        document.getElementById("CountryName").textContent = this.name;
        document.getElementById("OfficialLanguage").textContent = this.lang;
        document.getElementById("HelloWorld").textContent = this.greeting;
    }
}

let usa = new Country("USA", "Murican", "Why Hello there world! Have some McDonalds", ["red", "white", "blue"]);
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"]);
let algeria = new Country("Algeria", "Arabic and Berber", "Sup", ["blue", "yellow", "red"]);
let antiguaBarbuda = new Country("Antigua and Barbuda", "English", "Hello World!", ["red", "white", "blue", "black", "yellow"]);
let bahamas = new Country("Bahamas", "English", "Hey!", ["aquamarine", "yellow", "black"]);
let barbados = new Country("Barbados", "English", "What's up?", ["ultramarine", "gold", "black"]);
let belize = new Country("Belize", "English", "Greetings!", ["blue", "red", "white"]);
let canada = new Country("Canada", "English and French", "Yo!", ["red", "white", "black"]);
let costaRica = new Country("Costa Rica", "Spanish", "Ahoy!", ["blue", "white", "red", "black"]);


function SwitchCountry() {
    let select = document.getElementById("CountryList");
    let selectedCountry = select.value;
    let country;

    if (selectedCountry === "usa") {
        country = usa;
    } else if (selectedCountry === "mexico") {
        country = mexico;
    } else if (selectedCountry === "algeria") {
        country = algeria;
    } else if (selectedCountry === "antiguaBarbuda") {
        country = antiguaBarbuda;
    } else if (selectedCountry === "bahamas") {
        country = bahamas;
    } else if (selectedCountry === "barbados") {
        country = barbados;
    } else if (selectedCountry === "belize") {
        country = belize;
    } else if (selectedCountry === "canada") {
        country = canada;
    } else if (selectedCountry === "costaRica") {
        country = costaRica;
    }

    if (country) {
        country.displayColors();
    }
    console.log(`country:${country}`);
}
