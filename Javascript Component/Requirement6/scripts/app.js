
var app = new Vue({
    el: '#app',
    data: {
      loading: false,
      loaded: false,
      error: false,
      results: []
    },
    methods: {
      loadIssues: function() {
        this.loading = true;
        var self = this;
        setTimeout(function() {
          self.$http.jsonp("./test.jsonp", {jsonpCallback: "cb"}).then(self.issuesLoaded, self.issuesLoadingError);  
        }, 1000);
        
      },

      shouldShowLoadButton: function() {
        return !this.loading && !this.loaded;
      },

      shouldShowLoading: function() {
        return this.loading && !this.loaded;
      },

      shouldShowResults: function() {
        return this.loaded;
      },

      hasIssues: function() {
        return this.results && this.results.length > 0;
      },

      hasError: function() {
        return this.error;
      },
      
      issuesLoadingError: function(result) {
        
        this.results = [];
        this.loaded = true;
        this.error = true;
      },

      issuesLoaded: function(result) {
        
        if (result) {
          this.results = result.data;
        }
        this.loading = false;
        this.loaded = true;
      }
    }
});
