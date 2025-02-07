document.addEventListener('DOMContentLoaded', () => {
    const button = document.getElementById('sendData');
    const mouseCoordinates = [];

    document.addEventListener('mousemove', (event) => {
        const date = new Date();
        const formattedTime = date.toLocaleString();
        mouseCoordinates.push([event.clientX, event.clientY, formattedTime]);
    });

    button.addEventListener('click', () => {
        const data = JSON.stringify(mouseCoordinates);
        fetch('/api/MouseTrack/Add', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: data
        })
            .then(response => response.json())
            .then(data => {
                console.log('Data sent successfully:', data);
            })
            .catch(error => {
                console.error('Error:', error);
            });
    });
});