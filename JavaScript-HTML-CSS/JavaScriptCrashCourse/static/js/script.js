function AgeInDays() {
    var birthYear = prompt('What is your birth year?');
    var days = (2020 - birthYear) * 365;
    console.log(days);
    var h1 = document.createElement('h1');
    var textNotes = document.createTextNode('You are ' + days + ' days old.');
    h1.setAttribute('id', 'AgeInDays');
    h1.appendChild(textNotes);
    document.getElementById('flex-box-result').appendChild(h1);
}

function reset() {
    document.getElementById('AgeInDays').remove();
}

// Challenge 2

function GenerateCats() {
    var image = document.createElement('img');
    image.src="http://thecatapi.com/api/images/get?format=src&type=gif&size=small";

    var div = document.getElementById('flex-box-gen');
    div.appendChild(image);
}

// challenge 3: rock paper scissors
function rpsGame(yourChoice) {
    console.log("Player's choice: ", yourChoice.id);
    var humanChoice, botChoice, results, message;
    humanChoice = yourChoice.id;
    botChoice = numberToChoice(randToRpsInt());
    console.log("Computer's choice: ", botChoice);
    results = decideWinner(humanChoice, botChoice);  // [0, 1] human lost | bot won
    console.log(results);
    message = finalMessage(results) // {'message': 'You Won', 'color': 'green'}
    rpsFrontEnd(yourChoice, botChoice, message);

    function randToRpsInt() {
        return Math.floor(Math.random() * 3);
    }

    function numberToChoice(number) {
        return ['rock', 'paper', 'scissors'][number];
    }

    function decideWinner(humanChoice, botChoice) {
        var rpsDatabase = {
            'rock': {
                'rock': 0.5,
                'paper': 0,
                'scissors': 1,
            },
            'paper': {
                'rock': 1,
                'paper': 0.5,
                'scissors': 0,
            },
            'scissors': {
                'rock': 0,
                'paper': 1,
                'scissors':0.5
            }
        };

        var yourScore = rpsDatabase[humanChoice][botChoice];
        var computerScore = rpsDatabase[botChoice][humanChoice];

        return [yourScore, computerScore];
    }
    
    function finalMessage(results) {

        if (results[0] === 0) {
            return {'message': 'You Lost!', 'color': 'red'};
        } else if (results[0] === 0.5) {
            return {'message': 'It\'s a draw', 'color': 'yellow'};
        } else {
            return {'message': 'You Won!', 'color': 'green'};
        }
    }

    function rpsFrontEnd(yourChoice, botChoice, message) {

        var imageSourceDatabase = {
            'rock' : document.getElementById('rock').src,
            'paper': document.getElementById('paper').src,
            'scissors': document.getElementById('scissors').src,
        };

        document.getElementById('rock').remove();
        document.getElementById('paper').remove();
        document.getElementById('scissors').remove();
        
        var playerDiv = document.createElement('div');
        var messageDiv = document.createElement('div');
        var botDiv = document.createElement('div');

        playerDiv.innerHTML = "<img src='" + yourChoice.src + "' height=150 width=150 style='box-shadow: 0px 10px 50px " + message['color'] + ";'>";
        messageDiv.innerHTML = "<h1 style='color: " + message['color'] + ";'>" + message['message'] + "</h1>";
        botDiv.innerHTML = "<img src='" + imageSourceDatabase[botChoice] + "' height=150 width=150 style='box-shadow: opx 10px 50px " + message['color'] + ";'>";

        document.getElementById('flex-box-rps-div').appendChild(playerDiv);
        document.getElementById('flex-box-rps-div').appendChild(messageDiv);
        document.getElementById('flex-box-rps-div').appendChild(botDiv);
    }
}

// Challenge 5: change colour of all buttons
var allButtons = document.getElementsByClassName('btn');
var copyOfAllButtons = [];
for( var i = 0; i < allButtons.length; i++ ) {
    copyOfAllButtons.push(allButtons[i].classList[1]);
}
console.log(copyOfAllButtons);

function buttonColorChange(choice) {

    if( choice.value === 'random' ) {
        buttonRandom();
    } else if( choice.value === 'red' ) {
        buttonRed();
    } else if( choice.value === 'green' ) {
        buttonGreen();
    } else if( choice.value === 'reset' ) {
        buttonReset();
    }

}

function buttonRed() {

    for( var i = 0; i < allButtons.length; i++ ) {
        allButtons[i].classList.remove(allButtons[i].classList[1]);
        allButtons[i].classList.add('btn-danger');
    }
}

function buttonGreen() {

    for( var i = 0; i < allButtons.length; i++ ) {
        allButtons[i].classList.remove(allButtons[i].classList[1]);
        allButtons[i].classList.add('btn-success');
    }
}

function buttonRandom() {

    for( var i = 0; i < allButtons.length; i++ ) {
        allButtons[i].classList.remove(allButtons[i].classList[1]);
        allButtons[i].classList.add(['btn-success', 'btn-warning', 'btn-primary', 'btn-danger'][Math.floor(Math.random() * 4)]);
    }
}

function buttonReset() {

    for( var i = 0; i < allButtons.length; i++ ) {
        allButtons[i].classList.remove(allButtons[i].classList[1]);
        allButtons[i].classList.add(copyOfAllButtons[i]);
    }
}

// Challenge 5 Blackjack:

let blackjackGame = {
    'you': { 'scoreSpan': '#your-blackjack-result', 'div': '#your-box', 'score': 0 },
    'dealer': { 'scoreSpan': '#dealer-blackjack-result', 'div': '#dealer-box', 'score': 0 },
};

const YOU = blackjackGame['you'];
const DEALER = blackjackGame['dealer'];

const HITSOUND = new Audio('static/sounds/swish.m4a');

document.querySelector('#blackjack-hit-button').addEventListener('click', blackjackHit);
document.querySelector('#blackjack-deal-button').addEventListener('click', blackjackDeal);

function blackjackHit() {
    showCard(YOU);
}

function showCard(activePlayer) {
    let cardImage = document.createElement('img');
    cardImage.src = 'static/images/Q.png';
    document.querySelector(activePlayer['div']).appendChild(cardImage);
    HITSOUND.play();
}

function blackjackDeal() {
    let yourImages = document.querySelector('#your-box').querySelectorAll('img');

    for( i = 0; i < yourImages.length; i++ ) {
        yourImages[i].remove();
    }
}