
var dateFormat = "YYYY-MM-DD HH:mm Z";

Vue.component('issue', {
props: [
    'item'
    ],
template: `
<transition name="fade">
    <div class="issue-template">
        <h3 v-if="!isResolved()">{{title()}} - Started {{timeFromNow(item.beganAt)}}</h3>
        <h3 v-if="isResolved()">{{title()}} - Resolved {{timeFromNow(item.resolvedAt)}}</h3>
        <p>{{description()}}</p>
        <div v-if="hasUpdates()" style="padding-left:50px">
            <p>Updates:</p>
            <update v-for="update in item.updates" :key="update.id" v-bind:item="update"></update>
        </div>
        <hr />
    </div>
</transition>
`,
methods: {
    isResolved: function() {
        if (this.item && this.item.status && this.item.status == "Resolved") {
            return true;
        }

        return false;
    },

    hasUpdates: function() {
        if (this.item && this.item.updates && this.item.updates.length > 0) {
            return true;
        }

        return false;
    },

    timeFromNow: function(unparsedDate) {
        if (unparsedDate) {
            var date = moment(unparsedDate, dateFormat);
            if (date.isValid()) {
                return date.fromNow();
            }
        }

        return "at an unknown time";
    },

    title : function() {
        if (this.item && this.item.title && this.item.title.length > 0) {
            return this.item.title;
        }

        return "Unknown title";
    },

    description: function() {
        if( this.item && this.item.description && this.item.description.length > 0) {
            return this.item.description;
        }

        return "Issue has no description";
    }
}
});
