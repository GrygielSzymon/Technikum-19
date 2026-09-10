import baner from './baner.png';
import './App.css';

function Witaj(){
  let osoba = prompt("Jak masz na imie?")
  let nazwisko = prompt("Jak masz na nazwisko?")
  return <p className='App-p'>{osoba} {nazwisko} witaj w funkcji witaj()</p>
}


function SumaFu() {
    let start = prompt("Proszę podać 1szy element ciągu: ")
    start = parseInt(start)
    let end = prompt("Prosze podać ostatni element ciągu: ")
    end = parseInt(end)
    let step = prompt("Proszę podać krok: ")
    step = parseInt(step)
    let elem = ""
    let suma = 0;
    for (let i = start; i <= end;i = i+step) {
        elem = elem + i + "+"
        suma += i
    }

    elem = elem + 0 + "=" + suma
    return <p className='App-p'>Suma ciągu: {elem}</p>
}


function App() {
  return (
    <div className='App-strona'>
        <img src={baner} className='App-strona' alt='baner'/>
        <h2 className='App-h2'> Hello World!</h2>
        <Witaj/>
        <SumaFu/>
    </div>
  );
}

export default App;
