
fetch("https://localhost:5001/api/stocks").then(
    res => {
        res.json().then(
            data => {
                console.log(data);
                if (data.length > 0) {

                    var temp = "";
                    data.forEach((itemData) => {
                        temp += "<tr>";
                        temp += "<td>" + itemData.id + "</td>";
                        temp += "<td>" + itemData.productName + "</td>";
                        temp += "<td>" + itemData.partNumber + "</td>";
                        temp += "<td>" + itemData.productLabel + "</td>";
                        temp += "<td>" + itemData.startingInventory + "</td>";
                        temp += "<td>" + itemData.inventoryRecieved + "</td>";
                        temp += "<td>" + itemData.inventoryOnHand + "</td>";
                    });
                    document.getElementById('data').innerHTML = temp;
                }
            }
        )
    }
)

const fetchParams = {
    method: "GET",
    mode: "cors",
    cache: "default"
};

const url = "https://localhost:5001/api/stocks";

fetch(url, fetchParams)
    .then(res => {
        if (!res.ok) {
            throw new Error(res.statusText);
        }
        return res.json();
    })
    .then(data => {
        const characters = data;
        
        let inventoryOnHandData = [];
        let productNamesData = [];
        characters.forEach(function (character) {
            inventoryOnHandData.push([character.inventoryOnHand]);
            productNamesData.push([character.productName]);
        });

        var ctx = document.getElementById('myChart').getContext('2d');

        var myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: productNamesData,
                datasets: [{
                    label: '# of inventoryOnHand',
                    data:inventoryOnHandData,
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(255, 206, 86, 0.2)',
                        'rgba(75, 192, 192, 0.2)',
                        'rgba(153, 102, 255, 0.2)',
                        'rgba(255, 159, 64, 0.2)'
                    ],
                    borderColor: [
                        'rgba(255, 99, 132, 1)',
                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
                        'rgba(75, 192, 192, 1)',
                        'rgba(153, 102, 255, 1)',
                        'rgba(255, 159, 64, 1)'
                    ],
                    borderWidth: 1
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });

        
    })


