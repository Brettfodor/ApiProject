export default function Artist(artist){
    return `
        <section class="main-content__artist">
            <h3>${artist.name}</h3>
        </section>
    <section class="update-artist">
        <input class="update-artist__name" value="${artist.name}">
        <button class="update-artist__submit">Save Changes</button>
        <input class="update-artist__id" type="hidden" value="${artist.id}">
    </section>
    `
}