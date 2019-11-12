export default function Song(song){
    return `
        <section class="main-content__song">
            <h3>${song.title}</h3>
            <img class="song__image" src=${song.image}></img> 
        </section>
    <section class="update-song">
        <input class="update-song__name" value="${song.title}">
        <button class="update-song__submit">Save Changes</button>
        <input class="update-song__id" type="hidden" value="${song.id}">
        <input class="update-song__image" type="hidden" value="${song.image}">
        <select class= 'update-song__albumId' name="Album">
        <option value="1">East Atlanta Santa</option>
        <option value="2">Blink 182</option>
        <option value="3">The Poison</option>
        <option value="4">Full Moon Fever</option>
            </select>
    </section>
    `
}