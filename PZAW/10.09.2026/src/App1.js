import './App.css';

function Witaj(){
  let osoba = prompt("Jak masz na imie?")
  return <p>{osoba} witaj w funkcji witaj()</p>
}


function App() {
  return (
    <div>
      <h2>Hello world</h2>
      <Witaj />
      //wywołanie funkcji Witaj
    </div>
  );
}

export default App;
