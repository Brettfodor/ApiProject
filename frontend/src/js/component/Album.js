export default function Album(album){
    return `
        <section class="main-content__album">
            <h3>${album.title}</h3>
        </section>
    <section class="update-album">
        <input class="update-album__name" value="${album.title}">
        <button class="update-album__submit">Save Changes</button>
        <input class="update-album__id" type="hidden" value="${album.id}">
        <select class= 'update-album__artistId' name="Artist">
        <option value="1">Gucci Mane</option>
        <option value="2">Blink 182</option>
        <option value="3">Bullet Valentine</option>
        <option value="4">Tom Petty</option>
        </select>
    </section>
    `
}