export default function Song(song){
    return `
        <section class="main-content__song">
            <h3>${song.title}</h3>
        </section>
    <section class="update-song">
        <input class="update-song__name" value="${song.title}">
        <button class="update-song__submit">Save Changes</button>
        <input class="update-song__id" type="hidden" value="${song.id}">
        <input class="update-song__albumId" type="hidden" value="${song.albumId}">
    </section>
    `
}