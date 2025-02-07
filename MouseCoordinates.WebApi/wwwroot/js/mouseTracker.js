document.addEventListener('DOMContentLoaded', () => {
    const button = document.getElementById('sendData');
    const mouseCoordinates = [];

    document.addEventListener('mousemove', (event) => {
        const date = new Date();
        const formattedTime = date.toLocaleTimeString();

        mouseCoordinates.push({
            X: event.clientX,
            Y: event.clientY,
            DateTime: formattedTime
        });
    });

    button.addEventListener('click', () => {
        const data = JSON.stringify({ Coords: mouseCoordinates });

        fetch('/api/MouseTrack/Add', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: data
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error(`HTTP error status: ${response.status}`);
                }
                return response.json();
            })
            .then(data => {
                console.log('Data sent successfully:', data);
            })
            .catch(error => {
                console.error('Error:', error);
            });
    });
});