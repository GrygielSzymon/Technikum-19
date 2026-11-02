import Header from '../naglowek/Header';
import Footer from '../stopka/Footer';
import Trapery from './zimowe/Trapery.jpg';
import Kozaki from './zimowe/Kozaki.jpg';
import Sandaly from './letnie/Sandaly.jpg';
import Klapki from './letnie/Klapki.jpg';
import Drewniaki from './letnie/Drewniaki.jpg';
import Japonki from './letnie/Japonki.jpg';
import Rzymianki from './letnie/Rzymianki.jpg';
import '../App.css';
import React, { useState } from 'react';

function Main(props) {
    const [buty, setButy] = useState({
        zimowe: [
            {id: 0, nazwa: 'Trapery', zdjecie: Trapery, stanMagazynowy: 10},
            {id: 1, nazwa: 'Kozaki', zdjecie: Kozaki, stanMagazynowy: 10}
        ],
        letnie: [
            {id: 0, nazwa: 'Sandały', zdjecie: Sandaly, stanMagazynowy: 10},
            {id: 1, nazwa: 'Klapki', zdjecie: Klapki, stanMagazynowy: 10},
            {id: 2, nazwa: 'Drewniaki', zdjecie: Drewniaki, stanMagazynowy: 10}
        ]
    });

    function przyjmijObuwieZimowe() {
        const noweButyZimowe = [
            {id: 2, nazwa: 'Śniegowce', zdjecie: Trapery, stanMagazynowy: 10}
        ];

        setButy({
            ...buty,
            zimowe: [...buty.zimowe, ...noweButyZimowe]
        });
    }

    function przyjmijObuwieLetnie() {
    const noweButyLetnie = [
        {id: 3, nazwa: 'Japonki', zdjecie: Japonki, stanMagazynowy: 10},
        {id: 4, nazwa: 'Rzymianki', zdjecie: Rzymianki, stanMagazynowy: 10}
    ];

    setButy({
        ...buty,
        letnie: [...buty.letnie, ...noweButyLetnie]
    });

    }

    
    function usunWyprzedane() {
        setButy({
            letnie: buty.letnie.filter(but => but.stanMagazynowy > 0),
            zimowe: buty.zimowe.filter(but => but.stanMagazynowy > 0)
        });
    }
    
    return(
        <div>
            <Header firma="Moje Obuwie"/>
            <nav>
                <button onClick={przyjmijObuwieLetnie}>Przyjmij obuwie letnie</button>
                <button onClick={przyjmijObuwieZimowe}>Przyjmij obuwie zimowe</button>
                <button onClick={usunWyprzedane}>Usuń wyprzedane</button>
            </nav>

            <main>
                <h1>Nasza oferta:</h1>

                <h2>Obuwie Letnie</h2>
                {buty.letnie.map((but) => (
                    <div className='butKarta' key={but.id}>
                        <img src={but.zdjecie} alt={but.nazwa}/>
                        
                        <div className="trescKarty">
                            <h3>Rodzaj: {but.nazwa}</h3>
                            <p>Stan magazynu: {but.stanMagazynowy}</p>
                            <button>Sprzedaż detaliczna</button>
                            <button>Przyjecie tych butow</button>
                        </div>
                    </div>
                ))}

                <h2>Obuwie Zimowe</h2>

                {buty.zimowe.map((but) => (
                    <div className='butKarta' key={but.id}>
                        <img src={but.zdjecie} alt={but.nazwa}/>

                        <div className="trescKarty">
                            <h3>Rodzaj: {but.nazwa}</h3>
                            <p>Stan magazynu: {but.stanMagazynowy}</p>
                            <button>Sprzedaż detaliczna</button>
                            <button>Przyjęcie tych butów</button>
                        </div>
                    </div>
                ))}
                 
            </main>
            
            <Footer/>
        </div>
    );
}
export default Main;