// Note: This example requires that you consent to location sharing when
// prompted by your browser. If you see the error "The Geolocation service
// failed.", it means you probably did not give permission for the browser to
// locate you.
let map, infoWindow;

function initMap() {

    promiseLocations.done(function (locations) {
        const map = new google.maps.Map(document.getElementById("map"), {
            zoom: 3,
            center: { lat: -28.024, lng: 140.887 },
        });

        const markers = locations.map((location, i) => {
            return new google.maps.Marker({
                position: location,
                label: location.name
            });
        });
        // Add a marker clusterer to manage the markers.
        new MarkerClusterer(map, markers, {
            imagePath:
                "https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m",
        });
    });



}










function handleLocationError(browserHasGeolocation, infoWindow, pos) {
    infoWindow.setPosition(pos);
    infoWindow.setContent(
        browserHasGeolocation
            ? "Error: The Geolocation service failed."
            : "Error: Your browser doesn't support geolocation."
    );
    infoWindow.open(map);
}