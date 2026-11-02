function Footer() {
  const teraz = new Date();
  
  const nazwaDnia = teraz.toLocaleDateString('pl-PL', { weekday: 'long' });
  const dzien = teraz.getDate();
  const nazwaMiesiaca = teraz.toLocaleDateString('pl-PL', { month: 'long' });
  const rok = teraz.getFullYear();

  const nazwaDniaFormat = nazwaDnia.charAt(0).toUpperCase() + nazwaDnia.slice(1);

  return (
    <footer>
      <p>Dzisiaj jest: {nazwaDniaFormat}: {dzien} {nazwaMiesiaca} {rok} roku</p>
    </footer>
  );
}

export default Footer;
