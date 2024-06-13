const search      = document.querySelector('#search');
const searchInput = search.querySelector('input[type="text"]');

console.log('search is currently WIP, don\'worry!');

search.addEventListener('submit', (e) => {
    e.preventDefault();
    const input = searchInput.value;
    console.log(input)
});
