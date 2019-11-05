// export default function AlbumList(albums) {
//     return `
//     <section id='album-list'>
//     ${albums
//         .map(album => {
//             return `
//             <article class="album">
//             <li>
//                 <h3>${album.title}</h3>
//             </li>
//             </article>
//             `;
//         })
//         .join("")}
//     </section>  
//     `


export default function Albums(albums) {
    return `
    <ul>
            ${albums
              .map(album => {
                return `
                    <li>
                        <h3>${album.name}</h3>
                        <input class="album__id" type="hidden" value="${album.id}">
                        <button class="edit-album__submit" >Edit</button>
                        <button class="delete-album__submit">Delete</button>
                    </li>
                `;
              })
              .join("")}
         </ul>
         <section class="add-album">
            <input class="add-album__albumtitle" type="text" placeholder="Add an album!">
            <button class="add-album__submit">Submit</button>
        </section>
    `
}